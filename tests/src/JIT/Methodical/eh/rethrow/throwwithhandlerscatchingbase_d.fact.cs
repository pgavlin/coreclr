using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_throwwithhandlerscatchingbase_d_throwwithhandlerscatchingbase_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_throwwithhandlerscatchingbase_d_throwwithhandlerscatchingbase_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\throwwithhandlerscatchingbase_d\\throwwithhandlerscatchingbase_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
