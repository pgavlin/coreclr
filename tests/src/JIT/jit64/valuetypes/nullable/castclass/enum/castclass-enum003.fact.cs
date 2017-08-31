using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_enum_castclass_enum003_castclass_enum003_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_enum_castclass_enum003_castclass_enum003_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\enum\\castclass-enum003\\castclass-enum003.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
