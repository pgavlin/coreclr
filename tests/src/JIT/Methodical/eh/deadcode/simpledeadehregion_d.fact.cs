using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_simpledeadehregion_d_simpledeadehregion_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_simpledeadehregion_d_simpledeadehregion_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\simpledeadehregion_d\\simpledeadehregion_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
