using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__relexplicit1__relexplicit1_
    {
        [Fact]
        public void _explicit_misc__relexplicit1__relexplicit1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_relexplicit1\\_relexplicit1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
