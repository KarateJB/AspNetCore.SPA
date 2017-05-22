var gulp = require('gulp');
var server = require('karma').Server;

gulp.task('test', function (done) {
    new server({
        configFile: __dirname + '/ClientApp/test/karma.conf.js',
        singleRun: true
    }).start();
});