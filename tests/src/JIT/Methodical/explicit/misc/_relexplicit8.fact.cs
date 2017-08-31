using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__relexplicit8__relexplicit8_
    {
        [Fact]
        public void _explicit_misc__relexplicit8__relexplicit8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_relexplicit8\\_relexplicit8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
