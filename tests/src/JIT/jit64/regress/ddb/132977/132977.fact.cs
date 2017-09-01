using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_ddb_132977_132977_132977_
    {
        [OuterLoop]
        [Fact]
        public void _regress_ddb_132977_132977_132977_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\ddb\\132977\\132977\\132977.cmd");
        }
    }
}
