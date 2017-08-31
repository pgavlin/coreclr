using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_rethrow_throwwithhandlerscatchingbase_ro_throwwithhandlerscatchingbase_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_throwwithhandlerscatchingbase_ro_throwwithhandlerscatchingbase_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\throwwithhandlerscatchingbase_ro\\throwwithhandlerscatchingbase_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
