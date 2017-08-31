using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_throwwithhandlerscatchingbase_do_throwwithhandlerscatchingbase_do_
    {
        [Fact]
        public void _eh_rethrow_throwwithhandlerscatchingbase_do_throwwithhandlerscatchingbase_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\throwwithhandlerscatchingbase_do\\throwwithhandlerscatchingbase_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
