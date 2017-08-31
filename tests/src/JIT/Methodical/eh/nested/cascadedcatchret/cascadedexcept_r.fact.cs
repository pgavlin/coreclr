using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_cascadedcatchret_cascadedexcept_r_cascadedexcept_r_
    {
        [Fact]
        public void _eh_nested_cascadedcatchret_cascadedexcept_r_cascadedexcept_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\cascadedcatchret\\cascadedexcept_r\\cascadedexcept_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
