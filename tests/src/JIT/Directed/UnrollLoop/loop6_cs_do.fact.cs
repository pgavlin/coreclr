using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _UnrollLoop_loop6_cs_do_loop6_cs_do_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop6_cs_do_loop6_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop6_cs_do\\loop6_cs_do.cmd");
        }
    }
}
