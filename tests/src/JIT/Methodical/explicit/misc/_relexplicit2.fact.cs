using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__relexplicit2__relexplicit2_
    {
        [Fact]
        public void _explicit_misc__relexplicit2__relexplicit2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_relexplicit2\\_relexplicit2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
