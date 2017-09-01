using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_ddb_127931_127931_127931_
    {
        [Fact]
        public void _regress_ddb_127931_127931_127931_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ddb\\127931\\127931\\127931.cmd");
        }
    }
}
