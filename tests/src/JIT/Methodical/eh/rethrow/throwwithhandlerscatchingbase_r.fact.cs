using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_throwwithhandlerscatchingbase_r_throwwithhandlerscatchingbase_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_throwwithhandlerscatchingbase_r_throwwithhandlerscatchingbase_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\throwwithhandlerscatchingbase_r\\throwwithhandlerscatchingbase_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
