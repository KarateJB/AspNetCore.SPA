var gulp = require('gulp');
var rename = require('gulp-rename');
var server = require('karma').Server;
var root_path = {
    webroot: "./wwwroot/"
}

//library source
root_path.nmSrc = "./node_modules/";
//library destination
root_path.packageLib = root_path.webroot + "js/lib-npm/"


//font-awesome
gulp.task('copy-fa-css', function () {
    return gulp.src(root_path.nmSrc + "/font-awesome/fonts/*", {
        base: root_path.nmSrc + '/font-awesome/fonts/'
    }).pipe(gulp.dest(root_path.packageLib + '/font-awesome/fonts/'));
});

gulp.task('copy-fa-fonts', function () {
    return gulp.src(root_path.nmSrc + "/font-awesome/css/font-awesome.min.css", {
        base: root_path.nmSrc + '/font-awesome/css/'
    }).pipe(gulp.dest(root_path.packageLib + '/font-awesome/css/'));
});

//bootstrap
gulp.task('copy-bootstrap', function () {
  return gulp.src(root_path.nmSrc + "/bootstrap/dist/**/bootstrap.min.*", {
    base: root_path.nmSrc + '/bootstrap/dist/'
  }).pipe(gulp.dest(root_path.packageLib + '/bootstrap/'));
});

//sweetalert2
gulp.task('copy-sweetalert2', function () {
    return gulp.src(root_path.nmSrc + "/sweetalert2/dist/sweetalert2*", {
        base: root_path.nmSrc + '/sweetalert2/dist/'
    }).pipe(gulp.dest(root_path.packageLib + '/sweetalert2/'));
});
//ng2-toastr
gulp.task('copy-ng2-toastr', function () {
    return gulp.src([
        root_path.nmSrc + "/ng2-toastr/bundles/*.min.js",
        root_path.nmSrc + "/ng2-toastr/bundles/*.min.css"
    ], {
            base: root_path.nmSrc + '/ng2-toastr/bundles/'
        }).pipe(gulp.dest(root_path.packageLib + '/ng2-toastr/'));
});

//jsnlog
gulp.task('copy-jsnlog', function () {
    return gulp.src(root_path.nmSrc + "/jsnlog/jsnlog*.js", {
        base: root_path.nmSrc + '/jsnlog/'
    }).pipe(gulp.dest(root_path.packageLib + '/jsnlog/'));
});

gulp.task('copy-jsnlog-typing', function () {
    return gulp.src(root_path.nmSrc + "/jsnlog/Definitions/jl.d.ts", {
        base: root_path.nmSrc + '/jsnlog/Definitions/'
    }).pipe(rename("jsnlog.d.ts")).pipe(gulp.dest(root_path.packageLib + '/typings/'));
});



/*
 *Tasks
 */

gulp.task('test', function (done) {
    new server({
        configFile: __dirname + '/ClientApp/test/karma.conf.js',
        singleRun: true
    }).start();
});

gulp.task("copy-all", [
    "copy-fa-css",
    "copy-fa-fonts",
    "copy-bootstrap",
    "copy-sweetalert2",
    "copy-ng2-toastr",
    "copy-jsnlog", 
    "copy-jsnlog-typing"
]);