using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadstatic_ThreadStatic05_ThreadStatic05_
    {
        [OuterLoop]
        [Fact]
        public void _threadstatic_ThreadStatic05_ThreadStatic05_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadstatic\\ThreadStatic05\\ThreadStatic05.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
