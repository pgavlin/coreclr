using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructPromote_SP1c_SP1c_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP1c_SP1c_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP1c\\SP1c.cmd");
        }
    }
}
