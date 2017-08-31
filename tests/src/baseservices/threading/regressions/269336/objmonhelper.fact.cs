using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _regressions_269336_objmonhelper_objmonhelper_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_269336_objmonhelper_objmonhelper_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\269336\\objmonhelper\\objmonhelper.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
