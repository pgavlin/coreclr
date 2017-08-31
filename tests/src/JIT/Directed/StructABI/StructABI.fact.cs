using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StructABI_StructABI_StructABI_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _StructABI_StructABI_StructABI_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StructABI\\StructABI\\StructABI.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
