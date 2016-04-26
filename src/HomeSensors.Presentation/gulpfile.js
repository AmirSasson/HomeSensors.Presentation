/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp'),
concat = require('gulp-concat'),
cssmin = require('gulp-cssmin'),
uglify = require('gulp-uglify');


var paths = {
    webroot: './wwwroot/',
    angularscripts: './node_modules/**/*.js',
    bootstrap : './node_modules/bootstrap/dist/css/*.css'

}

paths.destJs = paths.webroot + 'js';
paths.destCss = paths.webroot + 'css';



gulp.task('min:js', function () {
    return gulp.src([paths.angularscripts])
        .pipe(concat(paths.destJs + "/site.min.js"))
        //.pipe(uglify())
        .pipe(gulp.dest('.'));
});
gulp.task('min:css', function () {
    return gulp.src([paths.bootstrap])
        .pipe(concat(paths.destCss + "/site.min.css"))
        .pipe(cssmin())
        .pipe(gulp.dest('.'));
});
gulp.task("min", ['min:css', 'min:js']);
