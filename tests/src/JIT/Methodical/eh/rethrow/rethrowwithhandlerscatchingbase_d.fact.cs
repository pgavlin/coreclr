using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_rethrowwithhandlerscatchingbase_d_rethrowwithhandlerscatchingbase_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_rethrowwithhandlerscatchingbase_d_rethrowwithhandlerscatchingbase_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\rethrowwithhandlerscatchingbase_d\\rethrowwithhandlerscatchingbase_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
