using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _pinning_object_pin_object_pin_object_pin_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinning_object_pin_object_pin_object_pin_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\pinning\\object-pin\\object-pin\\object-pin.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
