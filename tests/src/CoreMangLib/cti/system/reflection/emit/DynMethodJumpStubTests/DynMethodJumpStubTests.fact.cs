using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_DynMethodJumpStubTests_DynMethodJumpStubTests_DynMethodJumpStubTests_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_DynMethodJumpStubTests_DynMethodJumpStubTests_DynMethodJumpStubTests_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\DynMethodJumpStubTests\\DynMethodJumpStubTests\\DynMethodJumpStubTests.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
