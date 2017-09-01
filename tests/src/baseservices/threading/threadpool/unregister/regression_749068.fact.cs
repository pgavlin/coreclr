using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _threadpool_unregister_regression_749068_regression_749068_
    {
        [OuterLoop]
        [Fact]
        public void _threadpool_unregister_regression_749068_regression_749068_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\unregister\\regression_749068\\regression_749068.cmd");
        }
    }
}
