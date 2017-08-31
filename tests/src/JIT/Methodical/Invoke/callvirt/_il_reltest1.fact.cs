using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_callvirt__il_reltest1__il_reltest1_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_callvirt__il_reltest1__il_reltest1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\callvirt\\_il_reltest1\\_il_reltest1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
