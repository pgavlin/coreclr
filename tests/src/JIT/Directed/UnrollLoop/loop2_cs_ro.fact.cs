using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _UnrollLoop_loop2_cs_ro_loop2_cs_ro_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop2_cs_ro_loop2_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop2_cs_ro\\loop2_cs_ro.cmd");
        }
    }
}
