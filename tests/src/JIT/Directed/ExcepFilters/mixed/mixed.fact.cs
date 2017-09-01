using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _ExcepFilters_mixed_mixed_mixed_
    {
        [OuterLoop]
        [Fact]
        public void _ExcepFilters_mixed_mixed_mixed_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\ExcepFilters\\mixed\\mixed\\mixed.cmd");
        }
    }
}
