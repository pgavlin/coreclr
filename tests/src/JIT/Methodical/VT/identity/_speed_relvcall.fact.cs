using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__speed_relvcall__speed_relvcall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__speed_relvcall__speed_relvcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_speed_relvcall\\_speed_relvcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
