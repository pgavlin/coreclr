using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblykeyfileattribute_AssemblyKeyFileAttributeCtor_AssemblyKeyFileAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblykeyfileattribute_AssemblyKeyFileAttributeCtor_AssemblyKeyFileAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblykeyfileattribute\\AssemblyKeyFileAttributeCtor\\AssemblyKeyFileAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
