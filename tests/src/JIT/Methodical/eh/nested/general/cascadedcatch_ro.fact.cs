using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_cascadedcatch_ro_cascadedcatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_general_cascadedcatch_ro_cascadedcatch_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\cascadedcatch_ro\\cascadedcatch_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
