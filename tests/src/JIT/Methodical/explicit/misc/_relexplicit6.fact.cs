using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__relexplicit6__relexplicit6_
    {
        [Fact]
        public void _explicit_misc__relexplicit6__relexplicit6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_relexplicit6\\_relexplicit6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
