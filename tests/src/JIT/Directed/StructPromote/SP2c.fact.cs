using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructPromote_SP2c_SP2c_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP2c_SP2c_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP2c\\SP2c.cmd");
        }
    }
}
