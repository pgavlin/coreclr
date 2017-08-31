using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_rethrowwithhandlerscatchingbase_do_rethrowwithhandlerscatchingbase_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_rethrowwithhandlerscatchingbase_do_rethrowwithhandlerscatchingbase_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\rethrowwithhandlerscatchingbase_do\\rethrowwithhandlerscatchingbase_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
