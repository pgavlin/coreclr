using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_callvirt__il_reltest3__il_reltest3_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_callvirt__il_reltest3__il_reltest3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\callvirt\\_il_reltest3\\_il_reltest3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
