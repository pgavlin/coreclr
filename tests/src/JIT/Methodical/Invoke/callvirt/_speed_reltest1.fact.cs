using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_callvirt__speed_reltest1__speed_reltest1_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_callvirt__speed_reltest1__speed_reltest1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\callvirt\\_speed_reltest1\\_speed_reltest1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
