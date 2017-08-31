using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__relvcall__relvcall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__relvcall__relvcall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_relvcall\\_relvcall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
