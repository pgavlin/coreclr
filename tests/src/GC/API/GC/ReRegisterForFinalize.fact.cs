using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_ReRegisterForFinalize_ReRegisterForFinalize_
    {
        [OuterLoop]
        [Fact]
        public void _GC_ReRegisterForFinalize_ReRegisterForFinalize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\ReRegisterForFinalize\\ReRegisterForFinalize.cmd");
        }
    }
}
