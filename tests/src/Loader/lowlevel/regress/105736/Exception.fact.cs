using CoreclrTestLib;
using Xunit;

namespace Loader_lowlevel
{
    class _regress_105736_Exception_Exception_
    {
        [OuterLoop]
        [Fact]
        public void _regress_105736_Exception_Exception_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\lowlevel\\regress\\105736\\Exception\\Exception.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
