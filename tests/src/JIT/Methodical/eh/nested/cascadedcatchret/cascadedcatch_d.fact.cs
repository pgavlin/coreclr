using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_cascadedcatchret_cascadedcatch_d_cascadedcatch_d_
    {
        [Fact]
        public void _eh_nested_cascadedcatchret_cascadedcatch_d_cascadedcatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\cascadedcatchret\\cascadedcatch_d\\cascadedcatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
