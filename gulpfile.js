var gulp = require('gulp');
var sass = require('gulp-sass');
var minifyCss = require('gulp-clean-css');
var notify = require('gulp-notify');
var jsmin = require('gulp-jsmin');
var rename = require('gulp-rename');
 
gulp.task('sass', function () {
    return gulp.src('./Assets/sass/**/*.scss')
    .pipe(sass().on('error', sass.logError))
    .pipe(minifyCss())
    .pipe(gulp.dest('./Assets/CSS'));
});

gulp.task('jsmin', function () {
    gulp.src('./Assets/js/**/*.js')
        .pipe(jsmin())
        .pipe(rename({suffix: '.min'}))
        .pipe(gulp.dest('./Assets/js'));
});

gulp.task('watch', function () {
    gulp.watch('./Assets/sass/**/*.scss', ['sass','jsmin']);
});

gulp.task('default', ['sass','jsmin']);
