using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_rethrowwithhandlerscatchingbase_ro_rethrowwithhandlerscatchingbase_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_rethrowwithhandlerscatchingbase_ro_rethrowwithhandlerscatchingbase_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\rethrowwithhandlerscatchingbase_ro\\rethrowwithhandlerscatchingbase_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
