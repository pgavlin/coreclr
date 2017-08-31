using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_enum_castclass_enum001_castclass_enum001_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_enum_castclass_enum001_castclass_enum001_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\enum\\castclass-enum001\\castclass-enum001.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
