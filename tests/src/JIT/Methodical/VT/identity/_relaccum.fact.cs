using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_identity__relaccum__relaccum_
    {
        [OuterLoop]
        [Fact]
        public void _VT_identity__relaccum__relaccum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\identity\\_relaccum\\_relaccum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
