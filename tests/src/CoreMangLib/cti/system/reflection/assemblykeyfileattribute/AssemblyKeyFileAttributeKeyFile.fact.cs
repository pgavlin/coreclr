using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblykeyfileattribute_AssemblyKeyFileAttributeKeyFile_AssemblyKeyFileAttributeKeyFile_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblykeyfileattribute_AssemblyKeyFileAttributeKeyFile_AssemblyKeyFileAttributeKeyFile_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblykeyfileattribute\\AssemblyKeyFileAttributeKeyFile\\AssemblyKeyFileAttributeKeyFile.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
