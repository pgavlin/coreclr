using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructPromote_SP1d_SP1d_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP1d_SP1d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP1d\\SP1d.cmd");
        }
    }
}
