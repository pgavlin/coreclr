using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_assemblyconfigurationattribute_AssemblyConfigurationAttributeCtor_AssemblyConfigurationAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_assemblyconfigurationattribute_AssemblyConfigurationAttributeCtor_AssemblyConfigurationAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\assemblyconfigurationattribute\\AssemblyConfigurationAttributeCtor\\AssemblyConfigurationAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
