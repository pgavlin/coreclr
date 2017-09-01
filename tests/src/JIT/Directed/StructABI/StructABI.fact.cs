using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructABI_StructABI_StructABI_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _StructABI_StructABI_StructABI_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructABI\\StructABI\\StructABI.cmd");
        }
    }
}
