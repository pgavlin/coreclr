using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_callvirt__il_reltest2__il_reltest2_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_callvirt__il_reltest2__il_reltest2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\callvirt\\_il_reltest2\\_il_reltest2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
