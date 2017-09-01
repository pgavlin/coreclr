using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _opt_regress_vswhidbey_223862_mul_exception_dbg_mul_exception_dbg_
    {
        [Fact]
        public void _opt_regress_vswhidbey_223862_mul_exception_dbg_mul_exception_dbg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\opt\\regress\\vswhidbey\\223862\\mul_exception_dbg\\mul_exception_dbg.cmd");
        }
    }
}
