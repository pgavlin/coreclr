using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__relexplicit7__relexplicit7_
    {
        [Fact]
        public void _explicit_misc__relexplicit7__relexplicit7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_relexplicit7\\_relexplicit7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
