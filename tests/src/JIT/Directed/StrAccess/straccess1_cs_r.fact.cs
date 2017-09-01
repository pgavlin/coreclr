using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StrAccess_straccess1_cs_r_straccess1_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _StrAccess_straccess1_cs_r_straccess1_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StrAccess\\straccess1_cs_r\\straccess1_cs_r.cmd");
        }
    }
}
