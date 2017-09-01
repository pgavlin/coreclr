using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _Boxing_simpvariant_simpvariant_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_simpvariant_simpvariant_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\simpvariant\\simpvariant.cmd");
        }
    }
}
