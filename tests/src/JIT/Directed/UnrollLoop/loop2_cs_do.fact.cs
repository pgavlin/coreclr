using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _UnrollLoop_loop2_cs_do_loop2_cs_do_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop2_cs_do_loop2_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop2_cs_do\\loop2_cs_do.cmd");
        }
    }
}
