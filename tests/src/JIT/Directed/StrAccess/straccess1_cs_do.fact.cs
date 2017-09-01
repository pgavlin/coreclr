using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StrAccess_straccess1_cs_do_straccess1_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _StrAccess_straccess1_cs_do_straccess1_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StrAccess\\straccess1_cs_do\\straccess1_cs_do.cmd");
        }
    }
}
