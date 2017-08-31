using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadstatic_ThreadStatic03_ThreadStatic03_
    {
        [OuterLoop]
        [Fact]
        public void _threadstatic_ThreadStatic03_ThreadStatic03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadstatic\\ThreadStatic03\\ThreadStatic03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
