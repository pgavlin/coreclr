using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_rethrowwithhandlerscatchingbase_r_rethrowwithhandlerscatchingbase_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_rethrowwithhandlerscatchingbase_r_rethrowwithhandlerscatchingbase_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\rethrowwithhandlerscatchingbase_r\\rethrowwithhandlerscatchingbase_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
