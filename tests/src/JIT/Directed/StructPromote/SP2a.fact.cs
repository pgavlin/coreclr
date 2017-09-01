using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructPromote_SP2a_SP2a_
    {
        [OuterLoop]
        [Fact]
        public void _StructPromote_SP2a_SP2a_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructPromote\\SP2a\\SP2a.cmd");
        }
    }
}
