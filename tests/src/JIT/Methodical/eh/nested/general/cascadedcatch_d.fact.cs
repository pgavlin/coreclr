using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_cascadedcatch_d_cascadedcatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_nested_general_cascadedcatch_d_cascadedcatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\cascadedcatch_d\\cascadedcatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
