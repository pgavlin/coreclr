using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_constructorinfo_ConstructorInfoTypeConstructorName_ConstructorInfoTypeConstructorName_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_constructorinfo_ConstructorInfoTypeConstructorName_ConstructorInfoTypeConstructorName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\constructorinfo\\ConstructorInfoTypeConstructorName\\ConstructorInfoTypeConstructorName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
