using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_ddb_87766_ddb87766_ddb87766_
    {
        [Fact]
        public void _regress_ddb_87766_ddb87766_ddb87766_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ddb\\87766\\ddb87766\\ddb87766.cmd");
        }
    }
}
